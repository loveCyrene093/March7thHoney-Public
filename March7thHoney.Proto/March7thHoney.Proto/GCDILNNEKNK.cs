using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCDILNNEKNK : IMessage<GCDILNNEKNK>, IMessage, IEquatable<GCDILNNEKNK>, IDeepCloneable<GCDILNNEKNK>, IBufferMessage
{
	private static readonly MessageParser<GCDILNNEKNK> _parser = new MessageParser<GCDILNNEKNK>(() => new GCDILNNEKNK());

	private UnknownFieldSet _unknownFields;

	public const int LPJDEMOMDIEFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_lPJDEMOMDIE_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> lPJDEMOMDIE_ = new RepeatedField<uint>();

	public const int AreaIdFieldNumber = 14;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCDILNNEKNK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCDILNNEKNKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LPJDEMOMDIE => lPJDEMOMDIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCDILNNEKNK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCDILNNEKNK(GCDILNNEKNK other)
		: this()
	{
		lPJDEMOMDIE_ = other.lPJDEMOMDIE_.Clone();
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCDILNNEKNK Clone()
	{
		return new GCDILNNEKNK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCDILNNEKNK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCDILNNEKNK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lPJDEMOMDIE_.Equals(other.lPJDEMOMDIE_))
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		num ^= lPJDEMOMDIE_.GetHashCode();
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		lPJDEMOMDIE_.WriteTo(ref output, _repeated_lPJDEMOMDIE_codec);
		if (AreaId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AreaId);
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
		num += lPJDEMOMDIE_.CalculateSize(_repeated_lPJDEMOMDIE_codec);
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCDILNNEKNK other)
	{
		if (other != null)
		{
			lPJDEMOMDIE_.Add(other.lPJDEMOMDIE_);
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
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
			case 8u:
			case 10u:
				lPJDEMOMDIE_.AddEntriesFrom(ref input, _repeated_lPJDEMOMDIE_codec);
				break;
			case 112u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
