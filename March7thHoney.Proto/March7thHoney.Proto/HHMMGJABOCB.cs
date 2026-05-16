using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHMMGJABOCB : IMessage<HHMMGJABOCB>, IMessage, IEquatable<HHMMGJABOCB>, IDeepCloneable<HHMMGJABOCB>, IBufferMessage
{
	private static readonly MessageParser<HHMMGJABOCB> _parser = new MessageParser<HHMMGJABOCB>(() => new HHMMGJABOCB());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 2;

	private uint pENLMEIJIFK_;

	public const int FBHGPPCKEICFieldNumber = 7;

	private static readonly FieldCodec<IPHFDELCNBD> _repeated_fBHGPPCKEIC_codec = FieldCodec.ForMessage(58u, IPHFDELCNBD.Parser);

	private readonly RepeatedField<IPHFDELCNBD> fBHGPPCKEIC_ = new RepeatedField<IPHFDELCNBD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHMMGJABOCB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHMMGJABOCBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IPHFDELCNBD> FBHGPPCKEIC => fBHGPPCKEIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMMGJABOCB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMMGJABOCB(HHMMGJABOCB other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		fBHGPPCKEIC_ = other.fBHGPPCKEIC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMMGJABOCB Clone()
	{
		return new HHMMGJABOCB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHMMGJABOCB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHMMGJABOCB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (!fBHGPPCKEIC_.Equals(other.fBHGPPCKEIC_))
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
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		num ^= fBHGPPCKEIC_.GetHashCode();
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
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PENLMEIJIFK);
		}
		fBHGPPCKEIC_.WriteTo(ref output, _repeated_fBHGPPCKEIC_codec);
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
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		num += fBHGPPCKEIC_.CalculateSize(_repeated_fBHGPPCKEIC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHMMGJABOCB other)
	{
		if (other != null)
		{
			if (other.PENLMEIJIFK != 0)
			{
				PENLMEIJIFK = other.PENLMEIJIFK;
			}
			fBHGPPCKEIC_.Add(other.fBHGPPCKEIC_);
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
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 58u:
				fBHGPPCKEIC_.AddEntriesFrom(ref input, _repeated_fBHGPPCKEIC_codec);
				break;
			}
		}
	}
}
