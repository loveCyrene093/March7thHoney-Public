using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicSetAutoDressInMagicUnitCsReq : IMessage<RogueMagicSetAutoDressInMagicUnitCsReq>, IMessage, IEquatable<RogueMagicSetAutoDressInMagicUnitCsReq>, IDeepCloneable<RogueMagicSetAutoDressInMagicUnitCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicSetAutoDressInMagicUnitCsReq> _parser = new MessageParser<RogueMagicSetAutoDressInMagicUnitCsReq>(() => new RogueMagicSetAutoDressInMagicUnitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KMPPNOFBNPMFieldNumber = 14;

	private bool kMPPNOFBNPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicSetAutoDressInMagicUnitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicSetAutoDressInMagicUnitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KMPPNOFBNPM
	{
		get
		{
			return kMPPNOFBNPM_;
		}
		set
		{
			kMPPNOFBNPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicSetAutoDressInMagicUnitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicSetAutoDressInMagicUnitCsReq(RogueMagicSetAutoDressInMagicUnitCsReq other)
		: this()
	{
		kMPPNOFBNPM_ = other.kMPPNOFBNPM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicSetAutoDressInMagicUnitCsReq Clone()
	{
		return new RogueMagicSetAutoDressInMagicUnitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicSetAutoDressInMagicUnitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicSetAutoDressInMagicUnitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KMPPNOFBNPM != other.KMPPNOFBNPM)
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
		if (KMPPNOFBNPM)
		{
			num ^= KMPPNOFBNPM.GetHashCode();
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
		if (KMPPNOFBNPM)
		{
			output.WriteRawTag(112);
			output.WriteBool(KMPPNOFBNPM);
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
		if (KMPPNOFBNPM)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicSetAutoDressInMagicUnitCsReq other)
	{
		if (other != null)
		{
			if (other.KMPPNOFBNPM)
			{
				KMPPNOFBNPM = other.KMPPNOFBNPM;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KMPPNOFBNPM = input.ReadBool();
			}
		}
	}
}
