using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooBornCsReq : IMessage<SpaceZooBornCsReq>, IMessage, IEquatable<SpaceZooBornCsReq>, IDeepCloneable<SpaceZooBornCsReq>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooBornCsReq> _parser = new MessageParser<SpaceZooBornCsReq>(() => new SpaceZooBornCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MAPBKCGFLGKFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_mAPBKCGFLGK_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> mAPBKCGFLGK_ = new RepeatedField<uint>();

	public const int FJJEHGPHDAOFieldNumber = 10;

	private uint fJJEHGPHDAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooBornCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooBornCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MAPBKCGFLGK => mAPBKCGFLGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJJEHGPHDAO
	{
		get
		{
			return fJJEHGPHDAO_;
		}
		set
		{
			fJJEHGPHDAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooBornCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooBornCsReq(SpaceZooBornCsReq other)
		: this()
	{
		mAPBKCGFLGK_ = other.mAPBKCGFLGK_.Clone();
		fJJEHGPHDAO_ = other.fJJEHGPHDAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooBornCsReq Clone()
	{
		return new SpaceZooBornCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooBornCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooBornCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mAPBKCGFLGK_.Equals(other.mAPBKCGFLGK_))
		{
			return false;
		}
		if (FJJEHGPHDAO != other.FJJEHGPHDAO)
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
		num ^= mAPBKCGFLGK_.GetHashCode();
		if (FJJEHGPHDAO != 0)
		{
			num ^= FJJEHGPHDAO.GetHashCode();
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
		mAPBKCGFLGK_.WriteTo(ref output, _repeated_mAPBKCGFLGK_codec);
		if (FJJEHGPHDAO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FJJEHGPHDAO);
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
		num += mAPBKCGFLGK_.CalculateSize(_repeated_mAPBKCGFLGK_codec);
		if (FJJEHGPHDAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJJEHGPHDAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooBornCsReq other)
	{
		if (other != null)
		{
			mAPBKCGFLGK_.Add(other.mAPBKCGFLGK_);
			if (other.FJJEHGPHDAO != 0)
			{
				FJJEHGPHDAO = other.FJJEHGPHDAO;
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
			case 42u:
				mAPBKCGFLGK_.AddEntriesFrom(ref input, _repeated_mAPBKCGFLGK_codec);
				break;
			case 80u:
				FJJEHGPHDAO = input.ReadUInt32();
				break;
			}
		}
	}
}
