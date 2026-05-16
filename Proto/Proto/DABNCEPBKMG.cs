using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DABNCEPBKMG : IMessage<DABNCEPBKMG>, IMessage, IEquatable<DABNCEPBKMG>, IDeepCloneable<DABNCEPBKMG>, IBufferMessage
{
	private static readonly MessageParser<DABNCEPBKMG> _parser = new MessageParser<DABNCEPBKMG>(() => new DABNCEPBKMG());

	private UnknownFieldSet _unknownFields;

	public const int IOJMFDDPBHIFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_iOJMFDDPBHI_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> iOJMFDDPBHI_ = new RepeatedField<uint>();

	public const int JFEKKNNHCOHFieldNumber = 11;

	private static readonly FieldCodec<MDFEFKDEFML> _repeated_jFEKKNNHCOH_codec = FieldCodec.ForMessage(90u, MDFEFKDEFML.Parser);

	private readonly RepeatedField<MDFEFKDEFML> jFEKKNNHCOH_ = new RepeatedField<MDFEFKDEFML>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DABNCEPBKMG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DABNCEPBKMGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IOJMFDDPBHI => iOJMFDDPBHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MDFEFKDEFML> JFEKKNNHCOH => jFEKKNNHCOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DABNCEPBKMG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DABNCEPBKMG(DABNCEPBKMG other)
		: this()
	{
		iOJMFDDPBHI_ = other.iOJMFDDPBHI_.Clone();
		jFEKKNNHCOH_ = other.jFEKKNNHCOH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DABNCEPBKMG Clone()
	{
		return new DABNCEPBKMG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DABNCEPBKMG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DABNCEPBKMG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iOJMFDDPBHI_.Equals(other.iOJMFDDPBHI_))
		{
			return false;
		}
		if (!jFEKKNNHCOH_.Equals(other.jFEKKNNHCOH_))
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
		num ^= iOJMFDDPBHI_.GetHashCode();
		num ^= jFEKKNNHCOH_.GetHashCode();
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
		iOJMFDDPBHI_.WriteTo(ref output, _repeated_iOJMFDDPBHI_codec);
		jFEKKNNHCOH_.WriteTo(ref output, _repeated_jFEKKNNHCOH_codec);
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
		num += iOJMFDDPBHI_.CalculateSize(_repeated_iOJMFDDPBHI_codec);
		num += jFEKKNNHCOH_.CalculateSize(_repeated_jFEKKNNHCOH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DABNCEPBKMG other)
	{
		if (other != null)
		{
			iOJMFDDPBHI_.Add(other.iOJMFDDPBHI_);
			jFEKKNNHCOH_.Add(other.jFEKKNNHCOH_);
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
			case 26u:
				iOJMFDDPBHI_.AddEntriesFrom(ref input, _repeated_iOJMFDDPBHI_codec);
				break;
			case 90u:
				jFEKKNNHCOH_.AddEntriesFrom(ref input, _repeated_jFEKKNNHCOH_codec);
				break;
			}
		}
	}
}
