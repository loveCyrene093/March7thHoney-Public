using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightBossInfo : IMessage<GridFightBossInfo>, IMessage, IEquatable<GridFightBossInfo>, IDeepCloneable<GridFightBossInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightBossInfo> _parser = new MessageParser<GridFightBossInfo>(() => new GridFightBossInfo());

	private UnknownFieldSet _unknownFields;

	public const int IJOPBPABPPMFieldNumber = 6;

	private static readonly FieldCodec<PJLBDMPEKFP> _repeated_iJOPBPABPPM_codec = FieldCodec.ForMessage(50u, PJLBDMPEKFP.Parser);

	private readonly RepeatedField<PJLBDMPEKFP> iJOPBPABPPM_ = new RepeatedField<PJLBDMPEKFP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightBossInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightBossInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PJLBDMPEKFP> IJOPBPABPPM => iJOPBPABPPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBossInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBossInfo(GridFightBossInfo other)
		: this()
	{
		iJOPBPABPPM_ = other.iJOPBPABPPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBossInfo Clone()
	{
		return new GridFightBossInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightBossInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightBossInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iJOPBPABPPM_.Equals(other.iJOPBPABPPM_))
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
		num ^= iJOPBPABPPM_.GetHashCode();
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
		iJOPBPABPPM_.WriteTo(ref output, _repeated_iJOPBPABPPM_codec);
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
		num += iJOPBPABPPM_.CalculateSize(_repeated_iJOPBPABPPM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightBossInfo other)
	{
		if (other != null)
		{
			iJOPBPABPPM_.Add(other.iJOPBPABPPM_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iJOPBPABPPM_.AddEntriesFrom(ref input, _repeated_iJOPBPABPPM_codec);
			}
		}
	}
}
