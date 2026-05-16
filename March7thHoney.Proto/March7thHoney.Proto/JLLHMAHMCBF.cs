using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLLHMAHMCBF : IMessage<JLLHMAHMCBF>, IMessage, IEquatable<JLLHMAHMCBF>, IDeepCloneable<JLLHMAHMCBF>, IBufferMessage
{
	private static readonly MessageParser<JLLHMAHMCBF> _parser = new MessageParser<JLLHMAHMCBF>(() => new JLLHMAHMCBF());

	private UnknownFieldSet _unknownFields;

	public const int FCNCGHEJJLGFieldNumber = 9;

	private static readonly FieldCodec<LBBJMHOHKMG> _repeated_fCNCGHEJJLG_codec = FieldCodec.ForMessage(74u, LBBJMHOHKMG.Parser);

	private readonly RepeatedField<LBBJMHOHKMG> fCNCGHEJJLG_ = new RepeatedField<LBBJMHOHKMG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLLHMAHMCBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLLHMAHMCBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LBBJMHOHKMG> FCNCGHEJJLG => fCNCGHEJJLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLHMAHMCBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLHMAHMCBF(JLLHMAHMCBF other)
		: this()
	{
		fCNCGHEJJLG_ = other.fCNCGHEJJLG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLHMAHMCBF Clone()
	{
		return new JLLHMAHMCBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLLHMAHMCBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLLHMAHMCBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fCNCGHEJJLG_.Equals(other.fCNCGHEJJLG_))
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
		num ^= fCNCGHEJJLG_.GetHashCode();
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
		fCNCGHEJJLG_.WriteTo(ref output, _repeated_fCNCGHEJJLG_codec);
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
		num += fCNCGHEJJLG_.CalculateSize(_repeated_fCNCGHEJJLG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLLHMAHMCBF other)
	{
		if (other != null)
		{
			fCNCGHEJJLG_.Add(other.fCNCGHEJJLG_);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fCNCGHEJJLG_.AddEntriesFrom(ref input, _repeated_fCNCGHEJJLG_codec);
			}
		}
	}
}
