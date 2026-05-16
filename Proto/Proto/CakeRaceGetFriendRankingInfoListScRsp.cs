using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceGetFriendRankingInfoListScRsp : IMessage<CakeRaceGetFriendRankingInfoListScRsp>, IMessage, IEquatable<CakeRaceGetFriendRankingInfoListScRsp>, IDeepCloneable<CakeRaceGetFriendRankingInfoListScRsp>, IBufferMessage
{
	private static readonly MessageParser<CakeRaceGetFriendRankingInfoListScRsp> _parser = new MessageParser<CakeRaceGetFriendRankingInfoListScRsp>(() => new CakeRaceGetFriendRankingInfoListScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int HFJNDOAIDOPFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_hFJNDOAIDOP_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> hFJNDOAIDOP_ = new RepeatedField<uint>();

	public const int CPBGLNGOCBAFieldNumber = 14;

	private static readonly FieldCodec<MGFEMHKICND> _repeated_cPBGLNGOCBA_codec = FieldCodec.ForMessage(114u, MGFEMHKICND.Parser);

	private readonly RepeatedField<MGFEMHKICND> cPBGLNGOCBA_ = new RepeatedField<MGFEMHKICND>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceGetFriendRankingInfoListScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceGetFriendRankingInfoListScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> HFJNDOAIDOP => hFJNDOAIDOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MGFEMHKICND> CPBGLNGOCBA => cPBGLNGOCBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceGetFriendRankingInfoListScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceGetFriendRankingInfoListScRsp(CakeRaceGetFriendRankingInfoListScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		hFJNDOAIDOP_ = other.hFJNDOAIDOP_.Clone();
		cPBGLNGOCBA_ = other.cPBGLNGOCBA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceGetFriendRankingInfoListScRsp Clone()
	{
		return new CakeRaceGetFriendRankingInfoListScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceGetFriendRankingInfoListScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceGetFriendRankingInfoListScRsp other)
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
		if (!hFJNDOAIDOP_.Equals(other.hFJNDOAIDOP_))
		{
			return false;
		}
		if (!cPBGLNGOCBA_.Equals(other.cPBGLNGOCBA_))
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
		num ^= hFJNDOAIDOP_.GetHashCode();
		num ^= cPBGLNGOCBA_.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		hFJNDOAIDOP_.WriteTo(ref output, _repeated_hFJNDOAIDOP_codec);
		cPBGLNGOCBA_.WriteTo(ref output, _repeated_cPBGLNGOCBA_codec);
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
		num += hFJNDOAIDOP_.CalculateSize(_repeated_hFJNDOAIDOP_codec);
		num += cPBGLNGOCBA_.CalculateSize(_repeated_cPBGLNGOCBA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceGetFriendRankingInfoListScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			hFJNDOAIDOP_.Add(other.hFJNDOAIDOP_);
			cPBGLNGOCBA_.Add(other.cPBGLNGOCBA_);
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
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				hFJNDOAIDOP_.AddEntriesFrom(ref input, _repeated_hFJNDOAIDOP_codec);
				break;
			case 114u:
				cPBGLNGOCBA_.AddEntriesFrom(ref input, _repeated_cPBGLNGOCBA_codec);
				break;
			}
		}
	}
}
