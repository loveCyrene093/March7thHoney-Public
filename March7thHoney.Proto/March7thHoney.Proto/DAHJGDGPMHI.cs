using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DAHJGDGPMHI : IMessage<DAHJGDGPMHI>, IMessage, IEquatable<DAHJGDGPMHI>, IDeepCloneable<DAHJGDGPMHI>, IBufferMessage
{
	private static readonly MessageParser<DAHJGDGPMHI> _parser = new MessageParser<DAHJGDGPMHI>(() => new DAHJGDGPMHI());

	private UnknownFieldSet _unknownFields;

	public const int IAGMNHPPLGBFieldNumber = 8;

	private ItemCostData iAGMNHPPLGB_;

	public const int PIGDIFAKIGMFieldNumber = 11;

	private int pIGDIFAKIGM_;

	public const int KALHJPDHBJCFieldNumber = 12;

	private static readonly MapField<uint, ItemCostData>.Codec _map_kALHJPDHBJC_codec = new MapField<uint, ItemCostData>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, ItemCostData.Parser), 98u);

	private readonly MapField<uint, ItemCostData> kALHJPDHBJC_ = new MapField<uint, ItemCostData>();

	public const int JKIMLIPMKFHFieldNumber = 14;

	private uint jKIMLIPMKFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DAHJGDGPMHI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DAHJGDGPMHIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData IAGMNHPPLGB
	{
		get
		{
			return iAGMNHPPLGB_;
		}
		set
		{
			iAGMNHPPLGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PIGDIFAKIGM
	{
		get
		{
			return pIGDIFAKIGM_;
		}
		set
		{
			pIGDIFAKIGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, ItemCostData> KALHJPDHBJC => kALHJPDHBJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKIMLIPMKFH
	{
		get
		{
			return jKIMLIPMKFH_;
		}
		set
		{
			jKIMLIPMKFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAHJGDGPMHI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAHJGDGPMHI(DAHJGDGPMHI other)
		: this()
	{
		iAGMNHPPLGB_ = ((other.iAGMNHPPLGB_ != null) ? other.iAGMNHPPLGB_.Clone() : null);
		pIGDIFAKIGM_ = other.pIGDIFAKIGM_;
		kALHJPDHBJC_ = other.kALHJPDHBJC_.Clone();
		jKIMLIPMKFH_ = other.jKIMLIPMKFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAHJGDGPMHI Clone()
	{
		return new DAHJGDGPMHI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DAHJGDGPMHI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DAHJGDGPMHI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IAGMNHPPLGB, other.IAGMNHPPLGB))
		{
			return false;
		}
		if (PIGDIFAKIGM != other.PIGDIFAKIGM)
		{
			return false;
		}
		if (!KALHJPDHBJC.Equals(other.KALHJPDHBJC))
		{
			return false;
		}
		if (JKIMLIPMKFH != other.JKIMLIPMKFH)
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
		if (iAGMNHPPLGB_ != null)
		{
			num ^= IAGMNHPPLGB.GetHashCode();
		}
		if (PIGDIFAKIGM != 0)
		{
			num ^= PIGDIFAKIGM.GetHashCode();
		}
		num ^= KALHJPDHBJC.GetHashCode();
		if (JKIMLIPMKFH != 0)
		{
			num ^= JKIMLIPMKFH.GetHashCode();
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
		if (iAGMNHPPLGB_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IAGMNHPPLGB);
		}
		if (PIGDIFAKIGM != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PIGDIFAKIGM);
		}
		kALHJPDHBJC_.WriteTo(ref output, _map_kALHJPDHBJC_codec);
		if (JKIMLIPMKFH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JKIMLIPMKFH);
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
		if (iAGMNHPPLGB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IAGMNHPPLGB);
		}
		if (PIGDIFAKIGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PIGDIFAKIGM);
		}
		num += kALHJPDHBJC_.CalculateSize(_map_kALHJPDHBJC_codec);
		if (JKIMLIPMKFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKIMLIPMKFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DAHJGDGPMHI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iAGMNHPPLGB_ != null)
		{
			if (iAGMNHPPLGB_ == null)
			{
				IAGMNHPPLGB = new ItemCostData();
			}
			IAGMNHPPLGB.MergeFrom(other.IAGMNHPPLGB);
		}
		if (other.PIGDIFAKIGM != 0)
		{
			PIGDIFAKIGM = other.PIGDIFAKIGM;
		}
		kALHJPDHBJC_.MergeFrom(other.kALHJPDHBJC_);
		if (other.JKIMLIPMKFH != 0)
		{
			JKIMLIPMKFH = other.JKIMLIPMKFH;
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
			case 66u:
				if (iAGMNHPPLGB_ == null)
				{
					IAGMNHPPLGB = new ItemCostData();
				}
				input.ReadMessage(IAGMNHPPLGB);
				break;
			case 88u:
				PIGDIFAKIGM = input.ReadInt32();
				break;
			case 98u:
				kALHJPDHBJC_.AddEntriesFrom(ref input, _map_kALHJPDHBJC_codec);
				break;
			case 112u:
				JKIMLIPMKFH = input.ReadUInt32();
				break;
			}
		}
	}
}
