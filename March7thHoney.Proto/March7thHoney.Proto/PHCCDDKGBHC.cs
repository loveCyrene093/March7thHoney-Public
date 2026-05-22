using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHCCDDKGBHC : IMessage<PHCCDDKGBHC>, IMessage, IEquatable<PHCCDDKGBHC>, IDeepCloneable<PHCCDDKGBHC>, IBufferMessage
{
	private static readonly MessageParser<PHCCDDKGBHC> _parser = new MessageParser<PHCCDDKGBHC>(() => new PHCCDDKGBHC());

	private UnknownFieldSet _unknownFields;

	public const int BuffListFieldNumber = 3;

	private static readonly FieldCodec<OLJJJBCKLDK> _repeated_buffList_codec = FieldCodec.ForMessage(26u, OLJJJBCKLDK.Parser);

	private readonly RepeatedField<OLJJJBCKLDK> buffList_ = new RepeatedField<OLJJJBCKLDK>();

	public const int AvatarListFieldNumber = 5;

	private static readonly FieldCodec<IGDMBAILEHI> _repeated_avatarList_codec = FieldCodec.ForMessage(42u, IGDMBAILEHI.Parser);

	private readonly RepeatedField<IGDMBAILEHI> avatarList_ = new RepeatedField<IGDMBAILEHI>();

	public const int GBHPHCMGBGKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_gBHPHCMGBGK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> gBHPHCMGBGK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHCCDDKGBHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHCCDDKGBHCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLJJJBCKLDK> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IGDMBAILEHI> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GBHPHCMGBGK => gBHPHCMGBGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHCCDDKGBHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHCCDDKGBHC(PHCCDDKGBHC other)
		: this()
	{
		buffList_ = other.buffList_.Clone();
		avatarList_ = other.avatarList_.Clone();
		gBHPHCMGBGK_ = other.gBHPHCMGBGK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHCCDDKGBHC Clone()
	{
		return new PHCCDDKGBHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHCCDDKGBHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHCCDDKGBHC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!gBHPHCMGBGK_.Equals(other.gBHPHCMGBGK_))
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
		num ^= buffList_.GetHashCode();
		num ^= avatarList_.GetHashCode();
		num ^= gBHPHCMGBGK_.GetHashCode();
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
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		gBHPHCMGBGK_.WriteTo(ref output, _repeated_gBHPHCMGBGK_codec);
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
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += gBHPHCMGBGK_.CalculateSize(_repeated_gBHPHCMGBGK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHCCDDKGBHC other)
	{
		if (other != null)
		{
			buffList_.Add(other.buffList_);
			avatarList_.Add(other.avatarList_);
			gBHPHCMGBGK_.Add(other.gBHPHCMGBGK_);
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
			case 26u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 42u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 80u:
			case 82u:
				gBHPHCMGBGK_.AddEntriesFrom(ref input, _repeated_gBHPHCMGBGK_codec);
				break;
			}
		}
	}
}
