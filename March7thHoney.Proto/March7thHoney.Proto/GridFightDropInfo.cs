using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightDropInfo : IMessage<GridFightDropInfo>, IMessage, IEquatable<GridFightDropInfo>, IDeepCloneable<GridFightDropInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightDropInfo> _parser = new MessageParser<GridFightDropInfo>(() => new GridFightDropInfo());

	private UnknownFieldSet _unknownFields;

	public const int PIBLJLBCKJLFieldNumber = 1;

	private static readonly FieldCodec<LHPPIAKKFME> _repeated_pIBLJLBCKJL_codec = FieldCodec.ForMessage(10u, LHPPIAKKFME.Parser);

	private readonly RepeatedField<LHPPIAKKFME> pIBLJLBCKJL_ = new RepeatedField<LHPPIAKKFME>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightDropInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDropInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHPPIAKKFME> PIBLJLBCKJL => pIBLJLBCKJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDropInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDropInfo(GridFightDropInfo other)
		: this()
	{
		pIBLJLBCKJL_ = other.pIBLJLBCKJL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDropInfo Clone()
	{
		return new GridFightDropInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightDropInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightDropInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pIBLJLBCKJL_.Equals(other.pIBLJLBCKJL_))
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
		num ^= pIBLJLBCKJL_.GetHashCode();
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
		pIBLJLBCKJL_.WriteTo(ref output, _repeated_pIBLJLBCKJL_codec);
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
		num += pIBLJLBCKJL_.CalculateSize(_repeated_pIBLJLBCKJL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightDropInfo other)
	{
		if (other != null)
		{
			pIBLJLBCKJL_.Add(other.pIBLJLBCKJL_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pIBLJLBCKJL_.AddEntriesFrom(ref input, _repeated_pIBLJLBCKJL_codec);
			}
		}
	}
}
