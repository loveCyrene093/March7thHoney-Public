using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFFKFKHHEOG : IMessage<FFFKFKHHEOG>, IMessage, IEquatable<FFFKFKHHEOG>, IDeepCloneable<FFFKFKHHEOG>, IBufferMessage
{
	private static readonly MessageParser<FFFKFKHHEOG> _parser = new MessageParser<FFFKFKHHEOG>(() => new FFFKFKHHEOG());

	private UnknownFieldSet _unknownFields;

	public const int DBOJCHBAHCIFieldNumber = 4;

	private uint dBOJCHBAHCI_;

	public const int GAFPECGGICCFieldNumber = 9;

	private uint gAFPECGGICC_;

	public const int GoldFieldNumber = 10;

	private EFEGKDHEMFN gold_;

	public const int ACKIBGGBFMOFieldNumber = 11;

	private uint aCKIBGGBFMO_;

	public const int UidFieldNumber = 12;

	private uint uid_;

	public const int KLFPGJNLFKGFieldNumber = 13;

	private uint kLFPGJNLFKG_;

	public const int GBCPGOAFEBCFieldNumber = 15;

	private uint gBCPGOAFEBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFFKFKHHEOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFFKFKHHEOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBOJCHBAHCI
	{
		get
		{
			return dBOJCHBAHCI_;
		}
		set
		{
			dBOJCHBAHCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAFPECGGICC
	{
		get
		{
			return gAFPECGGICC_;
		}
		set
		{
			gAFPECGGICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACKIBGGBFMO
	{
		get
		{
			return aCKIBGGBFMO_;
		}
		set
		{
			aCKIBGGBFMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLFPGJNLFKG
	{
		get
		{
			return kLFPGJNLFKG_;
		}
		set
		{
			kLFPGJNLFKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBCPGOAFEBC
	{
		get
		{
			return gBCPGOAFEBC_;
		}
		set
		{
			gBCPGOAFEBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFKFKHHEOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFKFKHHEOG(FFFKFKHHEOG other)
		: this()
	{
		dBOJCHBAHCI_ = other.dBOJCHBAHCI_;
		gAFPECGGICC_ = other.gAFPECGGICC_;
		gold_ = ((other.gold_ != null) ? other.gold_.Clone() : null);
		aCKIBGGBFMO_ = other.aCKIBGGBFMO_;
		uid_ = other.uid_;
		kLFPGJNLFKG_ = other.kLFPGJNLFKG_;
		gBCPGOAFEBC_ = other.gBCPGOAFEBC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFKFKHHEOG Clone()
	{
		return new FFFKFKHHEOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFFKFKHHEOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFFKFKHHEOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DBOJCHBAHCI != other.DBOJCHBAHCI)
		{
			return false;
		}
		if (GAFPECGGICC != other.GAFPECGGICC)
		{
			return false;
		}
		if (!object.Equals(Gold, other.Gold))
		{
			return false;
		}
		if (ACKIBGGBFMO != other.ACKIBGGBFMO)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (KLFPGJNLFKG != other.KLFPGJNLFKG)
		{
			return false;
		}
		if (GBCPGOAFEBC != other.GBCPGOAFEBC)
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
		if (DBOJCHBAHCI != 0)
		{
			num ^= DBOJCHBAHCI.GetHashCode();
		}
		if (GAFPECGGICC != 0)
		{
			num ^= GAFPECGGICC.GetHashCode();
		}
		if (gold_ != null)
		{
			num ^= Gold.GetHashCode();
		}
		if (ACKIBGGBFMO != 0)
		{
			num ^= ACKIBGGBFMO.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (KLFPGJNLFKG != 0)
		{
			num ^= KLFPGJNLFKG.GetHashCode();
		}
		if (GBCPGOAFEBC != 0)
		{
			num ^= GBCPGOAFEBC.GetHashCode();
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
		if (DBOJCHBAHCI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DBOJCHBAHCI);
		}
		if (GAFPECGGICC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GAFPECGGICC);
		}
		if (gold_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Gold);
		}
		if (ACKIBGGBFMO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ACKIBGGBFMO);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Uid);
		}
		if (KLFPGJNLFKG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KLFPGJNLFKG);
		}
		if (GBCPGOAFEBC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GBCPGOAFEBC);
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
		if (DBOJCHBAHCI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBOJCHBAHCI);
		}
		if (GAFPECGGICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAFPECGGICC);
		}
		if (gold_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Gold);
		}
		if (ACKIBGGBFMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACKIBGGBFMO);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (KLFPGJNLFKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLFPGJNLFKG);
		}
		if (GBCPGOAFEBC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBCPGOAFEBC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FFFKFKHHEOG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DBOJCHBAHCI != 0)
		{
			DBOJCHBAHCI = other.DBOJCHBAHCI;
		}
		if (other.GAFPECGGICC != 0)
		{
			GAFPECGGICC = other.GAFPECGGICC;
		}
		if (other.gold_ != null)
		{
			if (gold_ == null)
			{
				Gold = new EFEGKDHEMFN();
			}
			Gold.MergeFrom(other.Gold);
		}
		if (other.ACKIBGGBFMO != 0)
		{
			ACKIBGGBFMO = other.ACKIBGGBFMO;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.KLFPGJNLFKG != 0)
		{
			KLFPGJNLFKG = other.KLFPGJNLFKG;
		}
		if (other.GBCPGOAFEBC != 0)
		{
			GBCPGOAFEBC = other.GBCPGOAFEBC;
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
			case 32u:
				DBOJCHBAHCI = input.ReadUInt32();
				break;
			case 72u:
				GAFPECGGICC = input.ReadUInt32();
				break;
			case 82u:
				if (gold_ == null)
				{
					Gold = new EFEGKDHEMFN();
				}
				input.ReadMessage(Gold);
				break;
			case 88u:
				ACKIBGGBFMO = input.ReadUInt32();
				break;
			case 96u:
				Uid = input.ReadUInt32();
				break;
			case 104u:
				KLFPGJNLFKG = input.ReadUInt32();
				break;
			case 120u:
				GBCPGOAFEBC = input.ReadUInt32();
				break;
			}
		}
	}
}
