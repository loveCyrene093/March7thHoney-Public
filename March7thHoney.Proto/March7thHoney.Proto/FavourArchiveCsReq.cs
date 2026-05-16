using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FavourArchiveCsReq : IMessage<FavourArchiveCsReq>, IMessage, IEquatable<FavourArchiveCsReq>, IDeepCloneable<FavourArchiveCsReq>, IBufferMessage
{
	private static readonly MessageParser<FavourArchiveCsReq> _parser = new MessageParser<FavourArchiveCsReq>(() => new FavourArchiveCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PDLBECHDJBLFieldNumber = 4;

	private bool pDLBECHDJBL_;

	public const int AJMBOLHDGHKFieldNumber = 12;

	private uint aJMBOLHDGHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FavourArchiveCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FavourArchiveCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FavourArchiveCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FavourArchiveCsReq(FavourArchiveCsReq other)
		: this()
	{
		pDLBECHDJBL_ = other.pDLBECHDJBL_;
		aJMBOLHDGHK_ = other.aJMBOLHDGHK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FavourArchiveCsReq Clone()
	{
		return new FavourArchiveCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FavourArchiveCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FavourArchiveCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PDLBECHDJBL != other.PDLBECHDJBL)
		{
			return false;
		}
		if (AJMBOLHDGHK != other.AJMBOLHDGHK)
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
		if (PDLBECHDJBL)
		{
			num ^= PDLBECHDJBL.GetHashCode();
		}
		if (AJMBOLHDGHK != 0)
		{
			num ^= AJMBOLHDGHK.GetHashCode();
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
		if (PDLBECHDJBL)
		{
			output.WriteRawTag(32);
			output.WriteBool(PDLBECHDJBL);
		}
		if (AJMBOLHDGHK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AJMBOLHDGHK);
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
		if (PDLBECHDJBL)
		{
			num += 2;
		}
		if (AJMBOLHDGHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AJMBOLHDGHK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FavourArchiveCsReq other)
	{
		if (other != null)
		{
			if (other.PDLBECHDJBL)
			{
				PDLBECHDJBL = other.PDLBECHDJBL;
			}
			if (other.AJMBOLHDGHK != 0)
			{
				AJMBOLHDGHK = other.AJMBOLHDGHK;
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
			case 32u:
				PDLBECHDJBL = input.ReadBool();
				break;
			case 96u:
				AJMBOLHDGHK = input.ReadUInt32();
				break;
			}
		}
	}
}
