using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCDBPKAIHIN : IMessage<NCDBPKAIHIN>, IMessage, IEquatable<NCDBPKAIHIN>, IDeepCloneable<NCDBPKAIHIN>, IBufferMessage
{
	private static readonly MessageParser<NCDBPKAIHIN> _parser = new MessageParser<NCDBPKAIHIN>(() => new NCDBPKAIHIN());

	private UnknownFieldSet _unknownFields;

	public const int ItemValueFieldNumber = 2;

	private uint itemValue_;

	public const int GBHPHCMGBGKFieldNumber = 10;

	private static readonly FieldCodec<CAEABHJNLMI> _repeated_gBHPHCMGBGK_codec = FieldCodec.ForMessage(82u, CAEABHJNLMI.Parser);

	private readonly RepeatedField<CAEABHJNLMI> gBHPHCMGBGK_ = new RepeatedField<CAEABHJNLMI>();

	public const int BuffListFieldNumber = 12;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_buffList_codec = FieldCodec.ForMessage(98u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> buffList_ = new RepeatedField<HJGFDIKDIHO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCDBPKAIHIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCDBPKAIHINReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CAEABHJNLMI> GBHPHCMGBGK => gBHPHCMGBGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HJGFDIKDIHO> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDBPKAIHIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDBPKAIHIN(NCDBPKAIHIN other)
		: this()
	{
		itemValue_ = other.itemValue_;
		gBHPHCMGBGK_ = other.gBHPHCMGBGK_.Clone();
		buffList_ = other.buffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDBPKAIHIN Clone()
	{
		return new NCDBPKAIHIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCDBPKAIHIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCDBPKAIHIN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (!gBHPHCMGBGK_.Equals(other.gBHPHCMGBGK_))
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
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
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		num ^= gBHPHCMGBGK_.GetHashCode();
		num ^= buffList_.GetHashCode();
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
		if (ItemValue != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ItemValue);
		}
		gBHPHCMGBGK_.WriteTo(ref output, _repeated_gBHPHCMGBGK_codec);
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
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
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		num += gBHPHCMGBGK_.CalculateSize(_repeated_gBHPHCMGBGK_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCDBPKAIHIN other)
	{
		if (other != null)
		{
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			gBHPHCMGBGK_.Add(other.gBHPHCMGBGK_);
			buffList_.Add(other.buffList_);
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
				ItemValue = input.ReadUInt32();
				break;
			case 82u:
				gBHPHCMGBGK_.AddEntriesFrom(ref input, _repeated_gBHPHCMGBGK_codec);
				break;
			case 98u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			}
		}
	}
}
