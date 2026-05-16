using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPlayerReturnMultiDropInfoScRsp : IMessage<GetPlayerReturnMultiDropInfoScRsp>, IMessage, IEquatable<GetPlayerReturnMultiDropInfoScRsp>, IDeepCloneable<GetPlayerReturnMultiDropInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPlayerReturnMultiDropInfoScRsp> _parser = new MessageParser<GetPlayerReturnMultiDropInfoScRsp>(() => new GetPlayerReturnMultiDropInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int JNGHGLMBPOHFieldNumber = 13;

	private static readonly FieldCodec<AEOEFOILEBP> _repeated_jNGHGLMBPOH_codec = FieldCodec.ForMessage(106u, AEOEFOILEBP.Parser);

	private readonly RepeatedField<AEOEFOILEBP> jNGHGLMBPOH_ = new RepeatedField<AEOEFOILEBP>();

	public const int BMAGGBCMDLBFieldNumber = 15;

	private ENALOKIFDFH bMAGGBCMDLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPlayerReturnMultiDropInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPlayerReturnMultiDropInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<AEOEFOILEBP> JNGHGLMBPOH => jNGHGLMBPOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENALOKIFDFH BMAGGBCMDLB
	{
		get
		{
			return bMAGGBCMDLB_;
		}
		set
		{
			bMAGGBCMDLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlayerReturnMultiDropInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlayerReturnMultiDropInfoScRsp(GetPlayerReturnMultiDropInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		jNGHGLMBPOH_ = other.jNGHGLMBPOH_.Clone();
		bMAGGBCMDLB_ = ((other.bMAGGBCMDLB_ != null) ? other.bMAGGBCMDLB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlayerReturnMultiDropInfoScRsp Clone()
	{
		return new GetPlayerReturnMultiDropInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPlayerReturnMultiDropInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPlayerReturnMultiDropInfoScRsp other)
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
		if (!jNGHGLMBPOH_.Equals(other.jNGHGLMBPOH_))
		{
			return false;
		}
		if (!object.Equals(BMAGGBCMDLB, other.BMAGGBCMDLB))
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
		num ^= jNGHGLMBPOH_.GetHashCode();
		if (bMAGGBCMDLB_ != null)
		{
			num ^= BMAGGBCMDLB.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		jNGHGLMBPOH_.WriteTo(ref output, _repeated_jNGHGLMBPOH_codec);
		if (bMAGGBCMDLB_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BMAGGBCMDLB);
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
		num += jNGHGLMBPOH_.CalculateSize(_repeated_jNGHGLMBPOH_codec);
		if (bMAGGBCMDLB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMAGGBCMDLB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPlayerReturnMultiDropInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		jNGHGLMBPOH_.Add(other.jNGHGLMBPOH_);
		if (other.bMAGGBCMDLB_ != null)
		{
			if (bMAGGBCMDLB_ == null)
			{
				BMAGGBCMDLB = new ENALOKIFDFH();
			}
			BMAGGBCMDLB.MergeFrom(other.BMAGGBCMDLB);
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				jNGHGLMBPOH_.AddEntriesFrom(ref input, _repeated_jNGHGLMBPOH_codec);
				break;
			case 122u:
				if (bMAGGBCMDLB_ == null)
				{
					BMAGGBCMDLB = new ENALOKIFDFH();
				}
				input.ReadMessage(BMAGGBCMDLB);
				break;
			}
		}
	}
}
