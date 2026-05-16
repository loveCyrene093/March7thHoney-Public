using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AreaStepInfo : IMessage<AreaStepInfo>, IMessage, IEquatable<AreaStepInfo>, IDeepCloneable<AreaStepInfo>, IBufferMessage
{
	private static readonly MessageParser<AreaStepInfo> _parser = new MessageParser<AreaStepInfo>(() => new AreaStepInfo());

	private UnknownFieldSet _unknownFields;

	public const int GNMOOIOIIAPFieldNumber = 9;

	private static readonly FieldCodec<IDHNJFPAEGP> _repeated_gNMOOIOIIAP_codec = FieldCodec.ForMessage(74u, IDHNJFPAEGP.Parser);

	private readonly RepeatedField<IDHNJFPAEGP> gNMOOIOIIAP_ = new RepeatedField<IDHNJFPAEGP>();

	public const int OIGHBOMFGGDFieldNumber = 10;

	private uint oIGHBOMFGGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AreaStepInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AreaStepInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IDHNJFPAEGP> GNMOOIOIIAP => gNMOOIOIIAP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIGHBOMFGGD
	{
		get
		{
			return oIGHBOMFGGD_;
		}
		set
		{
			oIGHBOMFGGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaStepInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaStepInfo(AreaStepInfo other)
		: this()
	{
		gNMOOIOIIAP_ = other.gNMOOIOIIAP_.Clone();
		oIGHBOMFGGD_ = other.oIGHBOMFGGD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaStepInfo Clone()
	{
		return new AreaStepInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AreaStepInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AreaStepInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gNMOOIOIIAP_.Equals(other.gNMOOIOIIAP_))
		{
			return false;
		}
		if (OIGHBOMFGGD != other.OIGHBOMFGGD)
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
		num ^= gNMOOIOIIAP_.GetHashCode();
		if (OIGHBOMFGGD != 0)
		{
			num ^= OIGHBOMFGGD.GetHashCode();
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
		gNMOOIOIIAP_.WriteTo(ref output, _repeated_gNMOOIOIIAP_codec);
		if (OIGHBOMFGGD != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OIGHBOMFGGD);
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
		num += gNMOOIOIIAP_.CalculateSize(_repeated_gNMOOIOIIAP_codec);
		if (OIGHBOMFGGD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIGHBOMFGGD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AreaStepInfo other)
	{
		if (other != null)
		{
			gNMOOIOIIAP_.Add(other.gNMOOIOIIAP_);
			if (other.OIGHBOMFGGD != 0)
			{
				OIGHBOMFGGD = other.OIGHBOMFGGD;
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
			case 74u:
				gNMOOIOIIAP_.AddEntriesFrom(ref input, _repeated_gNMOOIOIIAP_codec);
				break;
			case 80u:
				OIGHBOMFGGD = input.ReadUInt32();
				break;
			}
		}
	}
}
