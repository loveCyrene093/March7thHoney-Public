using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FiveDimFluteDataChangeNotify : IMessage<FiveDimFluteDataChangeNotify>, IMessage, IEquatable<FiveDimFluteDataChangeNotify>, IDeepCloneable<FiveDimFluteDataChangeNotify>, IBufferMessage
{
	private static readonly MessageParser<FiveDimFluteDataChangeNotify> _parser = new MessageParser<FiveDimFluteDataChangeNotify>(() => new FiveDimFluteDataChangeNotify());

	private UnknownFieldSet _unknownFields;

	public const int OHGFEGDFKNGFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_oHGFEGDFKNG_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> oHGFEGDFKNG_ = new RepeatedField<uint>();

	public const int EPPHGOBAFMPFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_ePPHGOBAFMP_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> ePPHGOBAFMP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FiveDimFluteDataChangeNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FiveDimFluteDataChangeNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OHGFEGDFKNG => oHGFEGDFKNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EPPHGOBAFMP => ePPHGOBAFMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimFluteDataChangeNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimFluteDataChangeNotify(FiveDimFluteDataChangeNotify other)
		: this()
	{
		oHGFEGDFKNG_ = other.oHGFEGDFKNG_.Clone();
		ePPHGOBAFMP_ = other.ePPHGOBAFMP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimFluteDataChangeNotify Clone()
	{
		return new FiveDimFluteDataChangeNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FiveDimFluteDataChangeNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FiveDimFluteDataChangeNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oHGFEGDFKNG_.Equals(other.oHGFEGDFKNG_))
		{
			return false;
		}
		if (!ePPHGOBAFMP_.Equals(other.ePPHGOBAFMP_))
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
		num ^= oHGFEGDFKNG_.GetHashCode();
		num ^= ePPHGOBAFMP_.GetHashCode();
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
		oHGFEGDFKNG_.WriteTo(ref output, _repeated_oHGFEGDFKNG_codec);
		ePPHGOBAFMP_.WriteTo(ref output, _repeated_ePPHGOBAFMP_codec);
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
		num += oHGFEGDFKNG_.CalculateSize(_repeated_oHGFEGDFKNG_codec);
		num += ePPHGOBAFMP_.CalculateSize(_repeated_ePPHGOBAFMP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FiveDimFluteDataChangeNotify other)
	{
		if (other != null)
		{
			oHGFEGDFKNG_.Add(other.oHGFEGDFKNG_);
			ePPHGOBAFMP_.Add(other.ePPHGOBAFMP_);
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
				oHGFEGDFKNG_.AddEntriesFrom(ref input, _repeated_oHGFEGDFKNG_codec);
				break;
			case 96u:
			case 98u:
				ePPHGOBAFMP_.AddEntriesFrom(ref input, _repeated_ePPHGOBAFMP_codec);
				break;
			}
		}
	}
}
