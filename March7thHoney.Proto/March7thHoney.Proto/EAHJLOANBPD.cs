using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EAHJLOANBPD : IMessage<EAHJLOANBPD>, IMessage, IEquatable<EAHJLOANBPD>, IDeepCloneable<EAHJLOANBPD>, IBufferMessage
{
	private static readonly MessageParser<EAHJLOANBPD> _parser = new MessageParser<EAHJLOANBPD>(() => new EAHJLOANBPD());

	private UnknownFieldSet _unknownFields;

	public const int CLLGHDCNPOIFieldNumber = 14;

	private KJAGLIIDBGP cLLGHDCNPOI_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EAHJLOANBPD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EAHJLOANBPDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJAGLIIDBGP CLLGHDCNPOI
	{
		get
		{
			return cLLGHDCNPOI_;
		}
		set
		{
			cLLGHDCNPOI_ = value;
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
	public EAHJLOANBPD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAHJLOANBPD(EAHJLOANBPD other)
		: this()
	{
		cLLGHDCNPOI_ = ((other.cLLGHDCNPOI_ != null) ? other.cLLGHDCNPOI_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAHJLOANBPD Clone()
	{
		return new EAHJLOANBPD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EAHJLOANBPD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EAHJLOANBPD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CLLGHDCNPOI, other.CLLGHDCNPOI))
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
		if (cLLGHDCNPOI_ != null)
		{
			num ^= CLLGHDCNPOI.GetHashCode();
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
		if (cLLGHDCNPOI_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CLLGHDCNPOI);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (cLLGHDCNPOI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CLLGHDCNPOI);
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
	public void MergeFrom(EAHJLOANBPD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cLLGHDCNPOI_ != null)
		{
			if (cLLGHDCNPOI_ == null)
			{
				CLLGHDCNPOI = new KJAGLIIDBGP();
			}
			CLLGHDCNPOI.MergeFrom(other.CLLGHDCNPOI);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 114u:
				if (cLLGHDCNPOI_ == null)
				{
					CLLGHDCNPOI = new KJAGLIIDBGP();
				}
				input.ReadMessage(CLLGHDCNPOI);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
