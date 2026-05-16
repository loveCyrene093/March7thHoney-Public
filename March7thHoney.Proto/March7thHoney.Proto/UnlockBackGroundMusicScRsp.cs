using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnlockBackGroundMusicScRsp : IMessage<UnlockBackGroundMusicScRsp>, IMessage, IEquatable<UnlockBackGroundMusicScRsp>, IDeepCloneable<UnlockBackGroundMusicScRsp>, IBufferMessage
{
	private static readonly MessageParser<UnlockBackGroundMusicScRsp> _parser = new MessageParser<UnlockBackGroundMusicScRsp>(() => new UnlockBackGroundMusicScRsp());

	private UnknownFieldSet _unknownFields;

	public const int UnlockedMusicListFieldNumber = 7;

	private static readonly FieldCodec<MusicData> _repeated_unlockedMusicList_codec = FieldCodec.ForMessage(58u, MusicData.Parser);

	private readonly RepeatedField<MusicData> unlockedMusicList_ = new RepeatedField<MusicData>();

	public const int CHAKAAOEDHCFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_cHAKAAOEDHC_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> cHAKAAOEDHC_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UnlockBackGroundMusicScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UnlockBackGroundMusicScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MusicData> UnlockedMusicList => unlockedMusicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CHAKAAOEDHC => cHAKAAOEDHC_;

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
	public UnlockBackGroundMusicScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockBackGroundMusicScRsp(UnlockBackGroundMusicScRsp other)
		: this()
	{
		unlockedMusicList_ = other.unlockedMusicList_.Clone();
		cHAKAAOEDHC_ = other.cHAKAAOEDHC_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockBackGroundMusicScRsp Clone()
	{
		return new UnlockBackGroundMusicScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UnlockBackGroundMusicScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnlockBackGroundMusicScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!unlockedMusicList_.Equals(other.unlockedMusicList_))
		{
			return false;
		}
		if (!cHAKAAOEDHC_.Equals(other.cHAKAAOEDHC_))
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
		num ^= unlockedMusicList_.GetHashCode();
		num ^= cHAKAAOEDHC_.GetHashCode();
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
		unlockedMusicList_.WriteTo(ref output, _repeated_unlockedMusicList_codec);
		cHAKAAOEDHC_.WriteTo(ref output, _repeated_cHAKAAOEDHC_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		num += unlockedMusicList_.CalculateSize(_repeated_unlockedMusicList_codec);
		num += cHAKAAOEDHC_.CalculateSize(_repeated_cHAKAAOEDHC_codec);
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
	public void MergeFrom(UnlockBackGroundMusicScRsp other)
	{
		if (other != null)
		{
			unlockedMusicList_.Add(other.unlockedMusicList_);
			cHAKAAOEDHC_.Add(other.cHAKAAOEDHC_);
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
			case 58u:
				unlockedMusicList_.AddEntriesFrom(ref input, _repeated_unlockedMusicList_codec);
				break;
			case 80u:
			case 82u:
				cHAKAAOEDHC_.AddEntriesFrom(ref input, _repeated_cHAKAAOEDHC_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
