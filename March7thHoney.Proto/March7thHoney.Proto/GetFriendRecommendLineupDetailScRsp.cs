using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendRecommendLineupDetailScRsp : IMessage<GetFriendRecommendLineupDetailScRsp>, IMessage, IEquatable<GetFriendRecommendLineupDetailScRsp>, IDeepCloneable<GetFriendRecommendLineupDetailScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendRecommendLineupDetailScRsp> _parser = new MessageParser<GetFriendRecommendLineupDetailScRsp>(() => new GetFriendRecommendLineupDetailScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KeyFieldNumber = 5;

	private uint key_;

	public const int MEOFNGCFABJFieldNumber = 7;

	private static readonly FieldCodec<DisplayAvatarDetailInfo> _repeated_mEOFNGCFABJ_codec = FieldCodec.ForMessage(58u, DisplayAvatarDetailInfo.Parser);

	private readonly RepeatedField<DisplayAvatarDetailInfo> mEOFNGCFABJ_ = new RepeatedField<DisplayAvatarDetailInfo>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int TypeFieldNumber = 11;

	private NFKEJJIHOCJ type_;

	public const int UidFieldNumber = 15;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendRecommendLineupDetailScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendRecommendLineupDetailScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarDetailInfo> MEOFNGCFABJ => mEOFNGCFABJ_;

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
	public NFKEJJIHOCJ Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
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
	public GetFriendRecommendLineupDetailScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupDetailScRsp(GetFriendRecommendLineupDetailScRsp other)
		: this()
	{
		key_ = other.key_;
		mEOFNGCFABJ_ = other.mEOFNGCFABJ_.Clone();
		retcode_ = other.retcode_;
		type_ = other.type_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupDetailScRsp Clone()
	{
		return new GetFriendRecommendLineupDetailScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendRecommendLineupDetailScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendRecommendLineupDetailScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (!mEOFNGCFABJ_.Equals(other.mEOFNGCFABJ_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (Key != 0)
		{
			num ^= Key.GetHashCode();
		}
		num ^= mEOFNGCFABJ_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (Key != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Key);
		}
		mEOFNGCFABJ_.WriteTo(ref output, _repeated_mEOFNGCFABJ_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Type);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Uid);
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
		if (Key != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Key);
		}
		num += mEOFNGCFABJ_.CalculateSize(_repeated_mEOFNGCFABJ_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendRecommendLineupDetailScRsp other)
	{
		if (other != null)
		{
			if (other.Key != 0)
			{
				Key = other.Key;
			}
			mEOFNGCFABJ_.Add(other.mEOFNGCFABJ_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Type != NFKEJJIHOCJ.Pcpdhelpkem)
			{
				Type = other.Type;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 40u:
				Key = input.ReadUInt32();
				break;
			case 58u:
				mEOFNGCFABJ_.AddEntriesFrom(ref input, _repeated_mEOFNGCFABJ_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				Type = (NFKEJJIHOCJ)input.ReadEnum();
				break;
			case 120u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
