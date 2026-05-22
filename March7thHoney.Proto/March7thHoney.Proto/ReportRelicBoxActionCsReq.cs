using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReportRelicBoxActionCsReq : IMessage<ReportRelicBoxActionCsReq>, IMessage, IEquatable<ReportRelicBoxActionCsReq>, IDeepCloneable<ReportRelicBoxActionCsReq>, IBufferMessage
{
	private static readonly MessageParser<ReportRelicBoxActionCsReq> _parser = new MessageParser<ReportRelicBoxActionCsReq>(() => new ReportRelicBoxActionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CEDIPEGBNDHFieldNumber = 5;

	private uint cEDIPEGBNDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReportRelicBoxActionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ReportRelicBoxActionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEDIPEGBNDH
	{
		get
		{
			return cEDIPEGBNDH_;
		}
		set
		{
			cEDIPEGBNDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportRelicBoxActionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportRelicBoxActionCsReq(ReportRelicBoxActionCsReq other)
		: this()
	{
		cEDIPEGBNDH_ = other.cEDIPEGBNDH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportRelicBoxActionCsReq Clone()
	{
		return new ReportRelicBoxActionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ReportRelicBoxActionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReportRelicBoxActionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEDIPEGBNDH != other.CEDIPEGBNDH)
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
		if (CEDIPEGBNDH != 0)
		{
			num ^= CEDIPEGBNDH.GetHashCode();
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
		if (CEDIPEGBNDH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CEDIPEGBNDH);
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
		if (CEDIPEGBNDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEDIPEGBNDH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ReportRelicBoxActionCsReq other)
	{
		if (other != null)
		{
			if (other.CEDIPEGBNDH != 0)
			{
				CEDIPEGBNDH = other.CEDIPEGBNDH;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CEDIPEGBNDH = input.ReadUInt32();
			}
		}
	}
}
