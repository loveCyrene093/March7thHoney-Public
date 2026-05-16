using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ILKOFGPOFIA : IMessage<ILKOFGPOFIA>, IMessage, IEquatable<ILKOFGPOFIA>, IDeepCloneable<ILKOFGPOFIA>, IBufferMessage
{
	private static readonly MessageParser<ILKOFGPOFIA> _parser = new MessageParser<ILKOFGPOFIA>(() => new ILKOFGPOFIA());

	private UnknownFieldSet _unknownFields;

	public const int MOBPNNMGICCFieldNumber = 4;

	private uint mOBPNNMGICC_;

	public const int OPALKIJMGLHFieldNumber = 14;

	private uint oPALKIJMGLH_;

	public const int DKGNCNKPGKDFieldNumber = 15;

	private uint dKGNCNKPGKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ILKOFGPOFIA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ILKOFGPOFIAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOBPNNMGICC
	{
		get
		{
			return mOBPNNMGICC_;
		}
		set
		{
			mOBPNNMGICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPALKIJMGLH
	{
		get
		{
			return oPALKIJMGLH_;
		}
		set
		{
			oPALKIJMGLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKGNCNKPGKD
	{
		get
		{
			return dKGNCNKPGKD_;
		}
		set
		{
			dKGNCNKPGKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILKOFGPOFIA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILKOFGPOFIA(ILKOFGPOFIA other)
		: this()
	{
		mOBPNNMGICC_ = other.mOBPNNMGICC_;
		oPALKIJMGLH_ = other.oPALKIJMGLH_;
		dKGNCNKPGKD_ = other.dKGNCNKPGKD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILKOFGPOFIA Clone()
	{
		return new ILKOFGPOFIA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ILKOFGPOFIA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ILKOFGPOFIA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOBPNNMGICC != other.MOBPNNMGICC)
		{
			return false;
		}
		if (OPALKIJMGLH != other.OPALKIJMGLH)
		{
			return false;
		}
		if (DKGNCNKPGKD != other.DKGNCNKPGKD)
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
		if (MOBPNNMGICC != 0)
		{
			num ^= MOBPNNMGICC.GetHashCode();
		}
		if (OPALKIJMGLH != 0)
		{
			num ^= OPALKIJMGLH.GetHashCode();
		}
		if (DKGNCNKPGKD != 0)
		{
			num ^= DKGNCNKPGKD.GetHashCode();
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
		if (MOBPNNMGICC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MOBPNNMGICC);
		}
		if (OPALKIJMGLH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OPALKIJMGLH);
		}
		if (DKGNCNKPGKD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DKGNCNKPGKD);
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
		if (MOBPNNMGICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOBPNNMGICC);
		}
		if (OPALKIJMGLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPALKIJMGLH);
		}
		if (DKGNCNKPGKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKGNCNKPGKD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ILKOFGPOFIA other)
	{
		if (other != null)
		{
			if (other.MOBPNNMGICC != 0)
			{
				MOBPNNMGICC = other.MOBPNNMGICC;
			}
			if (other.OPALKIJMGLH != 0)
			{
				OPALKIJMGLH = other.OPALKIJMGLH;
			}
			if (other.DKGNCNKPGKD != 0)
			{
				DKGNCNKPGKD = other.DKGNCNKPGKD;
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
			case 32u:
				MOBPNNMGICC = input.ReadUInt32();
				break;
			case 112u:
				OPALKIJMGLH = input.ReadUInt32();
				break;
			case 120u:
				DKGNCNKPGKD = input.ReadUInt32();
				break;
			}
		}
	}
}
