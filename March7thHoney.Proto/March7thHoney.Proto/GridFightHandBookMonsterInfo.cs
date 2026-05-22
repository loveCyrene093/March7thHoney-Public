using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHandBookMonsterInfo : IMessage<GridFightHandBookMonsterInfo>, IMessage, IEquatable<GridFightHandBookMonsterInfo>, IDeepCloneable<GridFightHandBookMonsterInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHandBookMonsterInfo> _parser = new MessageParser<GridFightHandBookMonsterInfo>(() => new GridFightHandBookMonsterInfo());

	private UnknownFieldSet _unknownFields;

	public const int HGAHMIPIBLOFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_hGAHMIPIBLO_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> hGAHMIPIBLO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHandBookMonsterInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHandBookMonsterInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HGAHMIPIBLO => hGAHMIPIBLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookMonsterInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookMonsterInfo(GridFightHandBookMonsterInfo other)
		: this()
	{
		hGAHMIPIBLO_ = other.hGAHMIPIBLO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookMonsterInfo Clone()
	{
		return new GridFightHandBookMonsterInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHandBookMonsterInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHandBookMonsterInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hGAHMIPIBLO_.Equals(other.hGAHMIPIBLO_))
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
		num ^= hGAHMIPIBLO_.GetHashCode();
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
		hGAHMIPIBLO_.WriteTo(ref output, _repeated_hGAHMIPIBLO_codec);
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
		num += hGAHMIPIBLO_.CalculateSize(_repeated_hGAHMIPIBLO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHandBookMonsterInfo other)
	{
		if (other != null)
		{
			hGAHMIPIBLO_.Add(other.hGAHMIPIBLO_);
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
			if (num != 16 && num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hGAHMIPIBLO_.AddEntriesFrom(ref input, _repeated_hGAHMIPIBLO_codec);
			}
		}
	}
}
