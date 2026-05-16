using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FavourArchiveScRsp : IMessage<FavourArchiveScRsp>, IMessage, IEquatable<FavourArchiveScRsp>, IDeepCloneable<FavourArchiveScRsp>, IBufferMessage
{
	private static readonly MessageParser<FavourArchiveScRsp> _parser = new MessageParser<FavourArchiveScRsp>(() => new FavourArchiveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AJMBOLHDGHKFieldNumber = 2;

	private uint aJMBOLHDGHK_;

	public const int PDLBECHDJBLFieldNumber = 7;

	private bool pDLBECHDJBL_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FavourArchiveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FavourArchiveScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AJMBOLHDGHK
	{
		get
		{
			return aJMBOLHDGHK_;
		}
		set
		{
			aJMBOLHDGHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PDLBECHDJBL
	{
		get
		{
			return pDLBECHDJBL_;
		}
		set
		{
			pDLBECHDJBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FavourArchiveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FavourArchiveScRsp(FavourArchiveScRsp other)
		: this()
	{
		aJMBOLHDGHK_ = other.aJMBOLHDGHK_;
		pDLBECHDJBL_ = other.pDLBECHDJBL_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FavourArchiveScRsp Clone()
	{
		return new FavourArchiveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FavourArchiveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FavourArchiveScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AJMBOLHDGHK != other.AJMBOLHDGHK)
		{
			return false;
		}
		if (PDLBECHDJBL != other.PDLBECHDJBL)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (AJMBOLHDGHK != 0)
		{
			num ^= AJMBOLHDGHK.GetHashCode();
		}
		if (PDLBECHDJBL)
		{
			num ^= PDLBECHDJBL.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AJMBOLHDGHK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AJMBOLHDGHK);
		}
		if (PDLBECHDJBL)
		{
			output.WriteRawTag(56);
			output.WriteBool(PDLBECHDJBL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (AJMBOLHDGHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AJMBOLHDGHK);
		}
		if (PDLBECHDJBL)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FavourArchiveScRsp other)
	{
		if (other != null)
		{
			if (other.AJMBOLHDGHK != 0)
			{
				AJMBOLHDGHK = other.AJMBOLHDGHK;
			}
			if (other.PDLBECHDJBL)
			{
				PDLBECHDJBL = other.PDLBECHDJBL;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				AJMBOLHDGHK = input.ReadUInt32();
				break;
			case 56u:
				PDLBECHDJBL = input.ReadBool();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
