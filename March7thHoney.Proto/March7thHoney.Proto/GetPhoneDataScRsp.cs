using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPhoneDataScRsp : IMessage<GetPhoneDataScRsp>, IMessage, IEquatable<GetPhoneDataScRsp>, IDeepCloneable<GetPhoneDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPhoneDataScRsp> _parser = new MessageParser<GetPhoneDataScRsp>(() => new GetPhoneDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int OwnedPhoneThemesFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_ownedPhoneThemes_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> ownedPhoneThemes_ = new RepeatedField<uint>();

	public const int CurPhoneCaseFieldNumber = 3;

	private uint curPhoneCase_;

	public const int CurPhoneThemeFieldNumber = 5;

	private uint curPhoneTheme_;

	public const int OwnedPhoneCasesFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_ownedPhoneCases_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> ownedPhoneCases_ = new RepeatedField<uint>();

	public const int OwnedChatBubblesFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_ownedChatBubbles_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> ownedChatBubbles_ = new RepeatedField<uint>();

	public const int CurChatBubbleFieldNumber = 9;

	private uint curChatBubble_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPhoneDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPhoneDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> OwnedPhoneThemes => ownedPhoneThemes_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurPhoneCase
	{
		get
		{
			return curPhoneCase_;
		}
		set
		{
			curPhoneCase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurPhoneTheme
	{
		get
		{
			return curPhoneTheme_;
		}
		set
		{
			curPhoneTheme_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OwnedPhoneCases => ownedPhoneCases_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OwnedChatBubbles => ownedChatBubbles_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurChatBubble
	{
		get
		{
			return curChatBubble_;
		}
		set
		{
			curChatBubble_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPhoneDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPhoneDataScRsp(GetPhoneDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		ownedPhoneThemes_ = other.ownedPhoneThemes_.Clone();
		curPhoneCase_ = other.curPhoneCase_;
		curPhoneTheme_ = other.curPhoneTheme_;
		ownedPhoneCases_ = other.ownedPhoneCases_.Clone();
		ownedChatBubbles_ = other.ownedChatBubbles_.Clone();
		curChatBubble_ = other.curChatBubble_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPhoneDataScRsp Clone()
	{
		return new GetPhoneDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPhoneDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPhoneDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!ownedPhoneThemes_.Equals(other.ownedPhoneThemes_))
		{
			return false;
		}
		if (CurPhoneCase != other.CurPhoneCase)
		{
			return false;
		}
		if (CurPhoneTheme != other.CurPhoneTheme)
		{
			return false;
		}
		if (!ownedPhoneCases_.Equals(other.ownedPhoneCases_))
		{
			return false;
		}
		if (!ownedChatBubbles_.Equals(other.ownedChatBubbles_))
		{
			return false;
		}
		if (CurChatBubble != other.CurChatBubble)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= ownedPhoneThemes_.GetHashCode();
		if (CurPhoneCase != 0)
		{
			num ^= CurPhoneCase.GetHashCode();
		}
		if (CurPhoneTheme != 0)
		{
			num ^= CurPhoneTheme.GetHashCode();
		}
		num ^= ownedPhoneCases_.GetHashCode();
		num ^= ownedChatBubbles_.GetHashCode();
		if (CurChatBubble != 0)
		{
			num ^= CurChatBubble.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		ownedPhoneThemes_.WriteTo(ref output, _repeated_ownedPhoneThemes_codec);
		if (CurPhoneCase != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CurPhoneCase);
		}
		if (CurPhoneTheme != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CurPhoneTheme);
		}
		ownedPhoneCases_.WriteTo(ref output, _repeated_ownedPhoneCases_codec);
		ownedChatBubbles_.WriteTo(ref output, _repeated_ownedChatBubbles_codec);
		if (CurChatBubble != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CurChatBubble);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += ownedPhoneThemes_.CalculateSize(_repeated_ownedPhoneThemes_codec);
		if (CurPhoneCase != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPhoneCase);
		}
		if (CurPhoneTheme != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPhoneTheme);
		}
		num += ownedPhoneCases_.CalculateSize(_repeated_ownedPhoneCases_codec);
		num += ownedChatBubbles_.CalculateSize(_repeated_ownedChatBubbles_codec);
		if (CurChatBubble != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurChatBubble);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPhoneDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			ownedPhoneThemes_.Add(other.ownedPhoneThemes_);
			if (other.CurPhoneCase != 0)
			{
				CurPhoneCase = other.CurPhoneCase;
			}
			if (other.CurPhoneTheme != 0)
			{
				CurPhoneTheme = other.CurPhoneTheme;
			}
			ownedPhoneCases_.Add(other.ownedPhoneCases_);
			ownedChatBubbles_.Add(other.ownedChatBubbles_);
			if (other.CurChatBubble != 0)
			{
				CurChatBubble = other.CurChatBubble;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				ownedPhoneThemes_.AddEntriesFrom(ref input, _repeated_ownedPhoneThemes_codec);
				break;
			case 24u:
				CurPhoneCase = input.ReadUInt32();
				break;
			case 40u:
				CurPhoneTheme = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				ownedPhoneCases_.AddEntriesFrom(ref input, _repeated_ownedPhoneCases_codec);
				break;
			case 64u:
			case 66u:
				ownedChatBubbles_.AddEntriesFrom(ref input, _repeated_ownedChatBubbles_codec);
				break;
			case 72u:
				CurChatBubble = input.ReadUInt32();
				break;
			}
		}
	}
}
