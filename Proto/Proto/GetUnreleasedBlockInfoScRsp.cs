using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetUnreleasedBlockInfoScRsp : IMessage<GetUnreleasedBlockInfoScRsp>, IMessage, IEquatable<GetUnreleasedBlockInfoScRsp>, IDeepCloneable<GetUnreleasedBlockInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetUnreleasedBlockInfoScRsp> _parser = new MessageParser<GetUnreleasedBlockInfoScRsp>(() => new GetUnreleasedBlockInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DDBFEEIGPJIFieldNumber = 3;

	private long dDBFEEIGPJI_;

	public const int GOMNGAADJLMFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_gOMNGAADJLM_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> gOMNGAADJLM_ = new RepeatedField<uint>();

	public const int FLFPOJFLHODFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_fLFPOJFLHOD_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> fLFPOJFLHOD_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetUnreleasedBlockInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetUnreleasedBlockInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DDBFEEIGPJI
	{
		get
		{
			return dDBFEEIGPJI_;
		}
		set
		{
			dDBFEEIGPJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GOMNGAADJLM => gOMNGAADJLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FLFPOJFLHOD => fLFPOJFLHOD_;

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
	public GetUnreleasedBlockInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetUnreleasedBlockInfoScRsp(GetUnreleasedBlockInfoScRsp other)
		: this()
	{
		dDBFEEIGPJI_ = other.dDBFEEIGPJI_;
		gOMNGAADJLM_ = other.gOMNGAADJLM_.Clone();
		fLFPOJFLHOD_ = other.fLFPOJFLHOD_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetUnreleasedBlockInfoScRsp Clone()
	{
		return new GetUnreleasedBlockInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetUnreleasedBlockInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetUnreleasedBlockInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DDBFEEIGPJI != other.DDBFEEIGPJI)
		{
			return false;
		}
		if (!gOMNGAADJLM_.Equals(other.gOMNGAADJLM_))
		{
			return false;
		}
		if (!fLFPOJFLHOD_.Equals(other.fLFPOJFLHOD_))
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
		if (DDBFEEIGPJI != 0L)
		{
			num ^= DDBFEEIGPJI.GetHashCode();
		}
		num ^= gOMNGAADJLM_.GetHashCode();
		num ^= fLFPOJFLHOD_.GetHashCode();
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
		if (DDBFEEIGPJI != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(DDBFEEIGPJI);
		}
		gOMNGAADJLM_.WriteTo(ref output, _repeated_gOMNGAADJLM_codec);
		fLFPOJFLHOD_.WriteTo(ref output, _repeated_fLFPOJFLHOD_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (DDBFEEIGPJI != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DDBFEEIGPJI);
		}
		num += gOMNGAADJLM_.CalculateSize(_repeated_gOMNGAADJLM_codec);
		num += fLFPOJFLHOD_.CalculateSize(_repeated_fLFPOJFLHOD_codec);
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
	public void MergeFrom(GetUnreleasedBlockInfoScRsp other)
	{
		if (other != null)
		{
			if (other.DDBFEEIGPJI != 0L)
			{
				DDBFEEIGPJI = other.DDBFEEIGPJI;
			}
			gOMNGAADJLM_.Add(other.gOMNGAADJLM_);
			fLFPOJFLHOD_.Add(other.fLFPOJFLHOD_);
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
			case 24u:
				DDBFEEIGPJI = input.ReadInt64();
				break;
			case 40u:
			case 42u:
				gOMNGAADJLM_.AddEntriesFrom(ref input, _repeated_gOMNGAADJLM_codec);
				break;
			case 64u:
			case 66u:
				fLFPOJFLHOD_.AddEntriesFrom(ref input, _repeated_fLFPOJFLHOD_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
