using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCAIHNOHHAG : IMessage<PCAIHNOHHAG>, IMessage, IEquatable<PCAIHNOHHAG>, IDeepCloneable<PCAIHNOHHAG>, IBufferMessage
{
	private static readonly MessageParser<PCAIHNOHHAG> _parser = new MessageParser<PCAIHNOHHAG>(() => new PCAIHNOHHAG());

	private UnknownFieldSet _unknownFields;

	public const int DLFPDEHDNGKFieldNumber = 2;

	private bool dLFPDEHDNGK_;

	public const int ECBCOIDFPONFieldNumber = 6;

	private JAMLHOHBIGB eCBCOIDFPON_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int CurIndexFieldNumber = 14;

	private uint curIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCAIHNOHHAG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCAIHNOHHAGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DLFPDEHDNGK
	{
		get
		{
			return dLFPDEHDNGK_;
		}
		set
		{
			dLFPDEHDNGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB ECBCOIDFPON
	{
		get
		{
			return eCBCOIDFPON_;
		}
		set
		{
			eCBCOIDFPON_ = value;
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
	public uint CurIndex
	{
		get
		{
			return curIndex_;
		}
		set
		{
			curIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAIHNOHHAG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAIHNOHHAG(PCAIHNOHHAG other)
		: this()
	{
		dLFPDEHDNGK_ = other.dLFPDEHDNGK_;
		eCBCOIDFPON_ = ((other.eCBCOIDFPON_ != null) ? other.eCBCOIDFPON_.Clone() : null);
		retcode_ = other.retcode_;
		curIndex_ = other.curIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAIHNOHHAG Clone()
	{
		return new PCAIHNOHHAG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCAIHNOHHAG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCAIHNOHHAG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DLFPDEHDNGK != other.DLFPDEHDNGK)
		{
			return false;
		}
		if (!object.Equals(ECBCOIDFPON, other.ECBCOIDFPON))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CurIndex != other.CurIndex)
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
		if (DLFPDEHDNGK)
		{
			num ^= DLFPDEHDNGK.GetHashCode();
		}
		if (eCBCOIDFPON_ != null)
		{
			num ^= ECBCOIDFPON.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CurIndex != 0)
		{
			num ^= CurIndex.GetHashCode();
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
		if (DLFPDEHDNGK)
		{
			output.WriteRawTag(16);
			output.WriteBool(DLFPDEHDNGK);
		}
		if (eCBCOIDFPON_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ECBCOIDFPON);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (CurIndex != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CurIndex);
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
		if (DLFPDEHDNGK)
		{
			num += 2;
		}
		if (eCBCOIDFPON_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECBCOIDFPON);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CurIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCAIHNOHHAG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DLFPDEHDNGK)
		{
			DLFPDEHDNGK = other.DLFPDEHDNGK;
		}
		if (other.eCBCOIDFPON_ != null)
		{
			if (eCBCOIDFPON_ == null)
			{
				ECBCOIDFPON = new JAMLHOHBIGB();
			}
			ECBCOIDFPON.MergeFrom(other.ECBCOIDFPON);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.CurIndex != 0)
		{
			CurIndex = other.CurIndex;
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
			case 16u:
				DLFPDEHDNGK = input.ReadBool();
				break;
			case 50u:
				if (eCBCOIDFPON_ == null)
				{
					ECBCOIDFPON = new JAMLHOHBIGB();
				}
				input.ReadMessage(ECBCOIDFPON);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				CurIndex = input.ReadUInt32();
				break;
			}
		}
	}
}
