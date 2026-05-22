using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameData : IMessage<GridFightGameData>, IMessage, IEquatable<GridFightGameData>, IDeepCloneable<GridFightGameData>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameData> _parser = new MessageParser<GridFightGameData>(() => new GridFightGameData());

	private UnknownFieldSet _unknownFields;

	public const int PGFMICHMHFCFieldNumber = 12;

	private static readonly FieldCodec<GridFightGameItemInfo> _repeated_pGFMICHMHFC_codec = FieldCodec.ForMessage(98u, GridFightGameItemInfo.Parser);

	private readonly RepeatedField<GridFightGameItemInfo> pGFMICHMHFC_ = new RepeatedField<GridFightGameItemInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightGameItemInfo> PGFMICHMHFC => pGFMICHMHFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameData(GridFightGameData other)
		: this()
	{
		pGFMICHMHFC_ = other.pGFMICHMHFC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameData Clone()
	{
		return new GridFightGameData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pGFMICHMHFC_.Equals(other.pGFMICHMHFC_))
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
		num ^= pGFMICHMHFC_.GetHashCode();
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
		pGFMICHMHFC_.WriteTo(ref output, _repeated_pGFMICHMHFC_codec);
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
		num += pGFMICHMHFC_.CalculateSize(_repeated_pGFMICHMHFC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameData other)
	{
		if (other != null)
		{
			pGFMICHMHFC_.Add(other.pGFMICHMHFC_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pGFMICHMHFC_.AddEntriesFrom(ref input, _repeated_pGFMICHMHFC_codec);
			}
		}
	}
}
