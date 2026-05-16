using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesUnlockChange : IMessage<PlanetFesUnlockChange>, IMessage, IEquatable<PlanetFesUnlockChange>, IDeepCloneable<PlanetFesUnlockChange>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesUnlockChange> _parser = new MessageParser<PlanetFesUnlockChange>(() => new PlanetFesUnlockChange());

	private UnknownFieldSet _unknownFields;

	public const int HasPassedFieldNumber = 8;

	private bool hasPassed_;

	public const int FCAPBPHLNCJFieldNumber = 12;

	private IPIMEGCPBGM fCAPBPHLNCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesUnlockChange> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesUnlockChangeReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPIMEGCPBGM FCAPBPHLNCJ
	{
		get
		{
			return fCAPBPHLNCJ_;
		}
		set
		{
			fCAPBPHLNCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUnlockChange()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUnlockChange(PlanetFesUnlockChange other)
		: this()
	{
		hasPassed_ = other.hasPassed_;
		fCAPBPHLNCJ_ = ((other.fCAPBPHLNCJ_ != null) ? other.fCAPBPHLNCJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUnlockChange Clone()
	{
		return new PlanetFesUnlockChange(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesUnlockChange);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesUnlockChange other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (!object.Equals(FCAPBPHLNCJ, other.FCAPBPHLNCJ))
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
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (fCAPBPHLNCJ_ != null)
		{
			num ^= FCAPBPHLNCJ.GetHashCode();
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
		if (HasPassed)
		{
			output.WriteRawTag(64);
			output.WriteBool(HasPassed);
		}
		if (fCAPBPHLNCJ_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FCAPBPHLNCJ);
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
		if (HasPassed)
		{
			num += 2;
		}
		if (fCAPBPHLNCJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCAPBPHLNCJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesUnlockChange other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HasPassed)
		{
			HasPassed = other.HasPassed;
		}
		if (other.fCAPBPHLNCJ_ != null)
		{
			if (fCAPBPHLNCJ_ == null)
			{
				FCAPBPHLNCJ = new IPIMEGCPBGM();
			}
			FCAPBPHLNCJ.MergeFrom(other.FCAPBPHLNCJ);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 64u:
				HasPassed = input.ReadBool();
				break;
			case 98u:
				if (fCAPBPHLNCJ_ == null)
				{
					FCAPBPHLNCJ = new IPIMEGCPBGM();
				}
				input.ReadMessage(FCAPBPHLNCJ);
				break;
			}
		}
	}
}
