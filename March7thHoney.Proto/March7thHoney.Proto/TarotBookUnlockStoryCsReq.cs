using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookUnlockStoryCsReq : IMessage<TarotBookUnlockStoryCsReq>, IMessage, IEquatable<TarotBookUnlockStoryCsReq>, IDeepCloneable<TarotBookUnlockStoryCsReq>, IBufferMessage
{
	private static readonly MessageParser<TarotBookUnlockStoryCsReq> _parser = new MessageParser<TarotBookUnlockStoryCsReq>(() => new TarotBookUnlockStoryCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LEGLOIMNPECFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_lEGLOIMNPEC_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> lEGLOIMNPEC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookUnlockStoryCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookUnlockStoryCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LEGLOIMNPEC => lEGLOIMNPEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockStoryCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockStoryCsReq(TarotBookUnlockStoryCsReq other)
		: this()
	{
		lEGLOIMNPEC_ = other.lEGLOIMNPEC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockStoryCsReq Clone()
	{
		return new TarotBookUnlockStoryCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookUnlockStoryCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookUnlockStoryCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lEGLOIMNPEC_.Equals(other.lEGLOIMNPEC_))
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
		num ^= lEGLOIMNPEC_.GetHashCode();
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
		lEGLOIMNPEC_.WriteTo(ref output, _repeated_lEGLOIMNPEC_codec);
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
		num += lEGLOIMNPEC_.CalculateSize(_repeated_lEGLOIMNPEC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookUnlockStoryCsReq other)
	{
		if (other != null)
		{
			lEGLOIMNPEC_.Add(other.lEGLOIMNPEC_);
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
			if (num != 112 && num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lEGLOIMNPEC_.AddEntriesFrom(ref input, _repeated_lEGLOIMNPEC_codec);
			}
		}
	}
}
