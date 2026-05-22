using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DODFLOBPGGL : IMessage<DODFLOBPGGL>, IMessage, IEquatable<DODFLOBPGGL>, IDeepCloneable<DODFLOBPGGL>, IBufferMessage
{
	private static readonly MessageParser<DODFLOBPGGL> _parser = new MessageParser<DODFLOBPGGL>(() => new DODFLOBPGGL());

	private UnknownFieldSet _unknownFields;

	public const int MFNPHHEPPIDFieldNumber = 15;

	private uint mFNPHHEPPID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DODFLOBPGGL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DODFLOBPGGLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFNPHHEPPID
	{
		get
		{
			return mFNPHHEPPID_;
		}
		set
		{
			mFNPHHEPPID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODFLOBPGGL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODFLOBPGGL(DODFLOBPGGL other)
		: this()
	{
		mFNPHHEPPID_ = other.mFNPHHEPPID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODFLOBPGGL Clone()
	{
		return new DODFLOBPGGL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DODFLOBPGGL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DODFLOBPGGL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFNPHHEPPID != other.MFNPHHEPPID)
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
		if (MFNPHHEPPID != 0)
		{
			num ^= MFNPHHEPPID.GetHashCode();
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
		if (MFNPHHEPPID != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MFNPHHEPPID);
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
		if (MFNPHHEPPID != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFNPHHEPPID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DODFLOBPGGL other)
	{
		if (other != null)
		{
			if (other.MFNPHHEPPID != 0)
			{
				MFNPHHEPPID = other.MFNPHHEPPID;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				MFNPHHEPPID = input.ReadUInt32();
			}
		}
	}
}
