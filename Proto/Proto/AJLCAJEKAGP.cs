using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AJLCAJEKAGP : IMessage<AJLCAJEKAGP>, IMessage, IEquatable<AJLCAJEKAGP>, IDeepCloneable<AJLCAJEKAGP>, IBufferMessage
{
	private static readonly MessageParser<AJLCAJEKAGP> _parser = new MessageParser<AJLCAJEKAGP>(() => new AJLCAJEKAGP());

	private UnknownFieldSet _unknownFields;

	public const int DHAIJLJCJAFFieldNumber = 7;

	private static readonly FieldCodec<GrowthTartgetFuncType> _repeated_dHAIJLJCJAF_codec = FieldCodec.ForEnum(58u, (GrowthTartgetFuncType x) => (int)x, (int x) => (GrowthTartgetFuncType)x);

	private readonly RepeatedField<GrowthTartgetFuncType> dHAIJLJCJAF_ = new RepeatedField<GrowthTartgetFuncType>();

	public const int MMOPCKLPHIOFieldNumber = 11;

	private uint mMOPCKLPHIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AJLCAJEKAGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AJLCAJEKAGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GrowthTartgetFuncType> DHAIJLJCJAF => dHAIJLJCJAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMOPCKLPHIO
	{
		get
		{
			return mMOPCKLPHIO_;
		}
		set
		{
			mMOPCKLPHIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJLCAJEKAGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJLCAJEKAGP(AJLCAJEKAGP other)
		: this()
	{
		dHAIJLJCJAF_ = other.dHAIJLJCJAF_.Clone();
		mMOPCKLPHIO_ = other.mMOPCKLPHIO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJLCAJEKAGP Clone()
	{
		return new AJLCAJEKAGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AJLCAJEKAGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AJLCAJEKAGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dHAIJLJCJAF_.Equals(other.dHAIJLJCJAF_))
		{
			return false;
		}
		if (MMOPCKLPHIO != other.MMOPCKLPHIO)
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
		num ^= dHAIJLJCJAF_.GetHashCode();
		if (MMOPCKLPHIO != 0)
		{
			num ^= MMOPCKLPHIO.GetHashCode();
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
		dHAIJLJCJAF_.WriteTo(ref output, _repeated_dHAIJLJCJAF_codec);
		if (MMOPCKLPHIO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MMOPCKLPHIO);
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
		num += dHAIJLJCJAF_.CalculateSize(_repeated_dHAIJLJCJAF_codec);
		if (MMOPCKLPHIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMOPCKLPHIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AJLCAJEKAGP other)
	{
		if (other != null)
		{
			dHAIJLJCJAF_.Add(other.dHAIJLJCJAF_);
			if (other.MMOPCKLPHIO != 0)
			{
				MMOPCKLPHIO = other.MMOPCKLPHIO;
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
			case 56u:
			case 58u:
				dHAIJLJCJAF_.AddEntriesFrom(ref input, _repeated_dHAIJLJCJAF_codec);
				break;
			case 88u:
				MMOPCKLPHIO = input.ReadUInt32();
				break;
			}
		}
	}
}
