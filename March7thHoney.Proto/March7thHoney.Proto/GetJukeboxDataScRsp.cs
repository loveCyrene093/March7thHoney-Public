using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetJukeboxDataScRsp : IMessage<GetJukeboxDataScRsp>, IMessage, IEquatable<GetJukeboxDataScRsp>, IDeepCloneable<GetJukeboxDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetJukeboxDataScRsp> _parser = new MessageParser<GetJukeboxDataScRsp>(() => new GetJukeboxDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int UnlockedMusicListFieldNumber = 4;

	private static readonly FieldCodec<MusicData> _repeated_unlockedMusicList_codec = FieldCodec.ForMessage(34u, MusicData.Parser);

	private readonly RepeatedField<MusicData> unlockedMusicList_ = new RepeatedField<MusicData>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int JILKOPINLDCFieldNumber = 14;

	private MCPPIEJEBEF jILKOPINLDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetJukeboxDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetJukeboxDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MusicData> UnlockedMusicList => unlockedMusicList_;

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
	public MCPPIEJEBEF JILKOPINLDC
	{
		get
		{
			return jILKOPINLDC_;
		}
		set
		{
			jILKOPINLDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetJukeboxDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetJukeboxDataScRsp(GetJukeboxDataScRsp other)
		: this()
	{
		unlockedMusicList_ = other.unlockedMusicList_.Clone();
		retcode_ = other.retcode_;
		jILKOPINLDC_ = ((other.jILKOPINLDC_ != null) ? other.jILKOPINLDC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetJukeboxDataScRsp Clone()
	{
		return new GetJukeboxDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetJukeboxDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetJukeboxDataScRsp other)
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
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(JILKOPINLDC, other.JILKOPINLDC))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (jILKOPINLDC_ != null)
		{
			num ^= JILKOPINLDC.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (jILKOPINLDC_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JILKOPINLDC);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (jILKOPINLDC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JILKOPINLDC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetJukeboxDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		unlockedMusicList_.Add(other.unlockedMusicList_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.jILKOPINLDC_ != null)
		{
			if (jILKOPINLDC_ == null)
			{
				JILKOPINLDC = new MCPPIEJEBEF();
			}
			JILKOPINLDC.MergeFrom(other.JILKOPINLDC);
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
			case 34u:
				unlockedMusicList_.AddEntriesFrom(ref input, _repeated_unlockedMusicList_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (jILKOPINLDC_ == null)
				{
					JILKOPINLDC = new MCPPIEJEBEF();
				}
				input.ReadMessage(JILKOPINLDC);
				break;
			}
		}
	}
}
