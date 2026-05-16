using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveGetFriendAssistListScRsp : IMessage<IdleLiveGetFriendAssistListScRsp>, IMessage, IEquatable<IdleLiveGetFriendAssistListScRsp>, IDeepCloneable<IdleLiveGetFriendAssistListScRsp>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveGetFriendAssistListScRsp> _parser = new MessageParser<IdleLiveGetFriendAssistListScRsp>(() => new IdleLiveGetFriendAssistListScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int TargetSideFieldNumber = 14;

	private uint targetSide_;

	public const int FMMNAIAKEGLFieldNumber = 15;

	private static readonly FieldCodec<BIBLMLDGCOB> _repeated_fMMNAIAKEGL_codec = FieldCodec.ForMessage(122u, BIBLMLDGCOB.Parser);

	private readonly RepeatedField<BIBLMLDGCOB> fMMNAIAKEGL_ = new RepeatedField<BIBLMLDGCOB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveGetFriendAssistListScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveGetFriendAssistListScRspReflection.Descriptor.MessageTypes[0];

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
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BIBLMLDGCOB> FMMNAIAKEGL => fMMNAIAKEGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveGetFriendAssistListScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveGetFriendAssistListScRsp(IdleLiveGetFriendAssistListScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		targetSide_ = other.targetSide_;
		fMMNAIAKEGL_ = other.fMMNAIAKEGL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveGetFriendAssistListScRsp Clone()
	{
		return new IdleLiveGetFriendAssistListScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveGetFriendAssistListScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveGetFriendAssistListScRsp other)
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
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (!fMMNAIAKEGL_.Equals(other.fMMNAIAKEGL_))
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
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		num ^= fMMNAIAKEGL_.GetHashCode();
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
		if (TargetSide != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TargetSide);
		}
		fMMNAIAKEGL_.WriteTo(ref output, _repeated_fMMNAIAKEGL_codec);
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
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		num += fMMNAIAKEGL_.CalculateSize(_repeated_fMMNAIAKEGL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveGetFriendAssistListScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			fMMNAIAKEGL_.Add(other.fMMNAIAKEGL_);
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
			case 112u:
				TargetSide = input.ReadUInt32();
				break;
			case 122u:
				fMMNAIAKEGL_.AddEntriesFrom(ref input, _repeated_fMMNAIAKEGL_codec);
				break;
			}
		}
	}
}
