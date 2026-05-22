using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPamSkinDataScRsp : IMessage<GetPamSkinDataScRsp>, IMessage, IEquatable<GetPamSkinDataScRsp>, IDeepCloneable<GetPamSkinDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPamSkinDataScRsp> _parser = new MessageParser<GetPamSkinDataScRsp>(() => new GetPamSkinDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurSkinFieldNumber = 2;

	private uint curSkin_;

	public const int UnlockSkinListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_unlockSkinList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> unlockSkinList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPamSkinDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPamSkinDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurSkin
	{
		get
		{
			return curSkin_;
		}
		set
		{
			curSkin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockSkinList => unlockSkinList_;

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
	public GetPamSkinDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPamSkinDataScRsp(GetPamSkinDataScRsp other)
		: this()
	{
		curSkin_ = other.curSkin_;
		unlockSkinList_ = other.unlockSkinList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPamSkinDataScRsp Clone()
	{
		return new GetPamSkinDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPamSkinDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPamSkinDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurSkin != other.CurSkin)
		{
			return false;
		}
		if (!unlockSkinList_.Equals(other.unlockSkinList_))
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
		if (CurSkin != 0)
		{
			num ^= CurSkin.GetHashCode();
		}
		num ^= unlockSkinList_.GetHashCode();
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
		if (CurSkin != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CurSkin);
		}
		unlockSkinList_.WriteTo(ref output, _repeated_unlockSkinList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
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
		if (CurSkin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurSkin);
		}
		num += unlockSkinList_.CalculateSize(_repeated_unlockSkinList_codec);
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
	public void MergeFrom(GetPamSkinDataScRsp other)
	{
		if (other != null)
		{
			if (other.CurSkin != 0)
			{
				CurSkin = other.CurSkin;
			}
			unlockSkinList_.Add(other.unlockSkinList_);
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
			case 16u:
				CurSkin = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				unlockSkinList_.AddEntriesFrom(ref input, _repeated_unlockSkinList_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
